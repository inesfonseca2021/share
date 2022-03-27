import "bootstrap/dist/css/bootstrap.min.css"
import 'jquery'
import 'popper.js'
import "bootstrap/dist/js/bootstrap.js"


import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";



import firebase from "firebase";
// web app's Firebase configuration
const firebaseConfig = {
  apiKey: "AIzaSyDF3LQUqQA3jGno7Pk30y0di0FxIqVFXkI",
  authDomain: "webproject-60f9b.firebaseapp.com",
  projectId: "webproject-60f9b",
  storageBucket: "webproject-60f9b.appspot.com",
  messagingSenderId: "60484280487",
  appId: "1:60484280487:web:25d95f0adc6f7fe217fb82"
};
// Initialize Firebase
firebase.initializeApp(firebaseConfig);


createApp(App).use(router).mount("#app");