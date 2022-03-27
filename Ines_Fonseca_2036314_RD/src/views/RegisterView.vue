<!--https://mdbootstrap.com/docs/standard/extended/registration/    Registration form #7-->
<template >
  <section id="backgroundColor">
    <div class="mask d-flex align-items-center h-100 gradient-custom-3">
      <div class="container h-100">
        <div class="row d-flex justify-content-center align-items-center h-100">
          <div class="col-12 col-md-9 col-lg-7 col-xl-6">
            <!-- card form of the register-->
            <div class="card" style="border-radius: 15px">
              <div class="card-body p-5">
                <!-- register Starts -->
                <h2 class="text-center mb-5">Create an account</h2>
                <div class="form-outline mb-4">
                  <label class="form-label" for="form3Example1cg"
                    ><h6>Your Name</h6></label
                  >
                  <!-- input user name -->
                  <input
                    id="form3Example1cg user"
                    class="input form-control form-control-lg"
                    name="login-user"
                    type="text"
                    v-model="userSignUp" 
                    placeholder="Enter your username"
                    minlength="3"
                    equiredclass="form-control form-control-lg"
                    style="border-radius: 12.3rem"
                  />
                </div>
                
                <div class="form-outline mb-4">
                  <label class="form-label" for="form3Example3cg"
                    ><h6>Your Email</h6></label
                  >
                  <!-- input email -->
                  <input
                    id="form3Example1cg email"
                    class="input form-control form-control-lg"
                    type="email"
                    v-model="emailSignUp"
                    placeholder="Enter your email address"
                    requiredclass="form-control form-control-lg"
                    style="border-radius: 12.3rem"
                  />
                </div>

                <div class="form-outline mb-4">
                  <label class="form-label" for="form3Example4cg"
                    ><h6>Password</h6></label
                  >
                  <!-- input password -->
                  <input
                    id="form3Example1cg email passwordField"
                    class="input form-control form-control-lg"
                    type="password"
                    v-model="passwordSignUp"
                    data-type="password"
                    placeholder="Create your password"
                    required
                    minlength="5"
                    style="border-radius: 12.3rem"
                  />
                </div>  
                <!-- register submit -->
                <div class="text-center text-muted mt-5 mb-0">
                  <button
                    @click="SignUp"
                    type="submit"
                    value="Sign Up"
                    class="btn btn-primary btn-xl text-uppercas"
                  >
                    Register
                  </button>
                </div>
                <!-- redirection do login page -->
                <p class="text-center text-muted mt-5 mb-0">
                  Have already an account?
                  <a href="#!" class="fw-bold text-body"
                    ><u><router-link to="/login">Login here</router-link></u></a
                  >
                </p>
                 <!-- register Ends -->
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>


<script setup>

import { ref } from "vue";
import firebase from "firebase"; //import firebase
import { useRouter } from "vue-router"; // import router
const emailSignUp = ref("");
const passwordSignUp = ref("");
const router = useRouter(); // get a reference to our vue router
const SignUp = () => {
  firebase
    .auth() // get the auth api
    .createUserWithEmailAndPassword(emailSignUp.value, passwordSignUp.value) // values of the email and password
    .then((data) => {
      console.log(data);
      console.log("Successfully registered!");
      router.push("/"); // redirect to home
    })
    .catch((error) => {
      console.log(error.code);
      alert(error.message);
    });
};
</script>

<style scoped>
@import "@/assets/about.css";
#backgroundColor {
  background-color: #f7f3f3;
}
</style>