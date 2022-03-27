<template>
  <!-- admin page Starts-->
  <section ref="purpleDiv" id="purpleDiv" class="page-section">
    <div class="container" id="services">
      <div class="row text-center">
        <h4>(Admin inputs)</h4>
        <h2 class="section-heading text-uppercase">Services</h2>

      <!-- inputs-->
        <div class="col-md-3">
          <h4 class="my-3">Design</h4>
          <input
            class="service-box text-muted"
            type="text"
            placeholder="add service..."
            v-model="serviceDesign"
          />
        </div>

        <div class="col-md-3">
          <h4 class="my-3" >Workshops</h4>
          <input
            class="service-box text-muted"
            type="text"
            placeholder="add service..."
            v-model="serviceWorkshops"
          />
        </div>

        <div class="col-md-3">
          <h4 class="my-3">Strategy</h4>
          <input
            class="service-box text-muted"
            type="text"
            placeholder="add service..."
            v-model="serviceStrategy"
          />
        </div>
        <!-- content to simulate the original page (only for visual purposes)-->
        <div class="col-md-3">
          <h3 id="service-text text-muted">
            <img src="@/assets/arrow.png" alt="star" width="25px" />
            I like to use a human centered aproach to design, passionated people
            commited to a common and social impact.
          </h3>
          <div>
            <h4 id="call-to-action">Let´s work together!</h4>
            <button
              class="btn btn-primary btn-xl text-uppercase"
              href="#services"
            >
              enquire
            </button>
          </div>
        </div>
      </div>
    </div>
    <!-- button that saves the inputs-->
    <div class="text-center text-muted mt-5 mb-0">
      <button
        @click="guardar()"
        type="submit"
        value="submitServices"
        class="btn btn-primary btn-xl text-uppercas"
      >
        Submit
      </button>
    </div>
  </section>
  <!-- admin page Ends-->
</template>

<style scoped>
@import "@/assets/about.css";
/*inputs*/
.item p,
input {
  margin: 10px 3px;
  padding: 8px 15px 10px;
  border: 1px solid #eee;
  border-radius: 10px;
  display: inline-block;
  background-color: #fff;
  font-size: 16px;
}

</style>

<script>
import axios from "axios"; //import axios
export default {
  // inputs in the admin
  data() {
    return {
      serviceDesign: "",
      serviceWorkshops: "",
      serviceStrategy: "",
    };
  },
  methods: {
    guardar() {
      axios
        .post("https://webproject-60f9b-default-rtdb.firebaseio.com/.json", {
          serviceDesign: this.serviceDesign,
          serviceWorkshops: this.serviceWorkshops,
          serviceStrategy: this.serviceStrategy,
        })
        .then(
          (response) => (this.articleId = response.data.id),
          console.log("res " + this.articleId)
        );
    },
  },
};
</script>
