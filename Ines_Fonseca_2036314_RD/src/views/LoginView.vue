<!--https://mdbootstrap.com/docs/standard/extended/registration/    Registration form #7-->
<template >
  <section id="backgroundColor">
    <div class="mask d-flex align-items-center h-100 gradient-custom-3">
      <div class="container h-100">
        <div class="row d-flex justify-content-center align-items-center h-100">
          <div class="col-12 col-md-9 col-lg-7 col-xl-6">
            <!-- card form of the login-->
            <div class="card" style="border-radius: 15px">
              <div class="card-body p-5">
                <!-- login Starts -->
                <h2 class="text-center mb-5">Login</h2>
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
                    v-model="userSignin"
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
                    v-model="emailSignIn"
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
                    v-model="passwordSignin"
                    data-type="password"
                    placeholder="Create your password"
                    required
                    minlength="5"
                    style="border-radius: 12.3rem"
                  />
                </div>
                <!-- login submit -->
                <div class="text-center text-muted mt-5 mb-0">
                  <button
                    @click="signIn"
                    type="submit"
                    value="Sign Up"
                    class="btn btn-primary btn-xl text-uppercas"
                  >
                    Login
                  </button>
                </div>
                <!-- redirection do register page -->
                <p class="text-center text-muted mt-5 mb-0">
                  Don´t have an account?
                  <a class="fw-bold text-body"
                    ><u
                      ><router-link to="/register">Register here</router-link>
                    </u></a
                  >
                </p>
                <!-- </form> -->
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
const router = useRouter(); // get a reference to our vue router
const admin = ref(false);
const emailSignIn = ref("");
const passwordSignin = ref("");
const signIn = () => {
  
  firebase
    .auth()
    .signInWithEmailAndPassword(emailSignIn.value, passwordSignin.value)
    .then((data) => {
      if (data.user.uid == "yaijf9tVeVR3gDjygcaSwNF3oUp2") { //verify if the admin is correct username: Admin ; email:theadmin@gmail.com ;  pass: theAdmin
        admin.value = true; 
        router.push("/admin"); //goes to admin page if the email and pass is valid
      } else {
        console.log(data);
        router.push("/login"); // stays in the login page to try again
      }
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