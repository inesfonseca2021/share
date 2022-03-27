import { createRouter, createWebHistory } from 'vue-router'


import RegisterView from '../views/RegisterView.vue'
import AboutView from '../views/AboutView.vue'
import LoginView from '../views/LoginView.vue'
import ErrorView from '../views/ErrorView.vue'
import AdminView from '../views/AdminView.vue'



const routes = [
  
  {
    path: '/register',
    name: 'register',
    component:RegisterView 
  },
  {
    path: '/',
    name: 'about',
    component: AboutView
  },
  {
    path: '/login',
    name: 'login',
    component: LoginView
  },
  {
    path: '/admin',
    name: 'admin',
    component: AdminView
  },
  
  {
    path: '/:pathMatch(.*)*',
    name: 'error',
    component: ErrorView

  },
    
]


const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router