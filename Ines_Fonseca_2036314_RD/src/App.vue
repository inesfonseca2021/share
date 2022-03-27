<template>
  <!--******************************************* Navigation Menu Starts *******************************************-->

  <nav
    class="navbar navbar-expand-lg navbar-dark fixed-top"
    id="mainNav"
    v-if="!'error'.includes($route.name)"
  >
    <!--hides the navbar on the error page-->
    <router-link to="/"></router-link>
    <!--router-link of the homepage-->

    <div class="container">
      <!--arrow button for the top of the page-->
      <a class="navbar-brand" href="/#about"
        ><svg
          xmlns="http://www.w3.org/2000/svg"
          width="16"
          height="16"
          fill="currentColor"
          class="bi bi-arrow-up-circle"
          viewBox="0 0 16 16"
        >
          <path
            fill-rule="evenodd"
            d="M1 8a7 7 0 1 0 14 0A7 7 0 0 0 1 8zm15 0A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-7.5 3.5a.5.5 0 0 1-1 0V5.707L5.354 7.854a.5.5 0 1 1-.708-.708l3-3a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1-.708.708L8.5 5.707V11.5z"
          /></svg
      ></a>
      <!--burguer button of the responsive menu-->
      <button
        class="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#navbarResponsive"
        aria-controls="navbarResponsive"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <i class="fas fa-bars ms-1"></i>
      </button>
      <!--menu content-->
      <div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav text-uppercase ms-auto py-4 py-lg-0">
          <li class="nav-item">
            <a class="nav-link" href="/#about">About </a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="/#purpleDiv"> Services</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="/#msform">Work with me</a>
          </li>
          <li class="nav-item"><a class="nav-link" href="/login">Login</a></li>
        </ul>
      </div>
    </div>
  </nav>
  <!--******************************************* Navigation Menu Ends *******************************************-->

  <!--******************************************* Footer  Starts *******************************************-->
  <footer
    class="text-center text-lg-start bg-light text-muted"
    v-if="!'error'.includes($route.name)"
  >
    <!--hides the footer on the error page-->

    <div class="footer">
      <div class="container text-center text-md-start mt-5">
        <div class="row mt-3">
          <div class="col-md-3 col-lg-4 col-xl-3 mx-auto mb-4">
            <!--Footer content -->
            <h6 class="fw-bold mb-4">
              <!--balloon icone + message -->
              <svg
                xmlns="http://www.w3.org/2000/svg"
                width="20"
                height="20"
                fill="currentColor"
                class="bi bi-balloon"
                viewBox="0 0 16 16"
              >
                <path
                  fill-rule="evenodd"
                  d="M8 9.984C10.403 9.506 12 7.48 12 5a4 4 0 0 0-8 0c0 2.48 1.597 4.506 4 4.984ZM13 5c0 2.837-1.789 5.227-4.52 5.901l.244.487a.25.25 0 1 1-.448.224l-.008-.017c.008.11.02.202.037.29.054.27.161.488.419 1.003.288.578.235 1.15.076 1.629-.157.469-.422.867-.588 1.115l-.004.007a.25.25 0 1 1-.416-.278c.168-.252.4-.6.533-1.003.133-.396.163-.824-.049-1.246l-.013-.028c-.24-.48-.38-.758-.448-1.102a3.177 3.177 0 0 1-.052-.45l-.04.08a.25.25 0 1 1-.447-.224l.244-.487C4.789 10.227 3 7.837 3 5a5 5 0 0 1 10 0Zm-6.938-.495a2.003 2.003 0 0 1 1.443-1.443C7.773 2.994 8 2.776 8 2.5c0-.276-.226-.504-.498-.459a3.003 3.003 0 0 0-2.46 2.461c-.046.272.182.498.458.498s.494-.227.562-.495Z"
                /></svg
              >Hi! Thank you for being here!
            </h6>
            <p>
              I am Inês, a longlife learner and love solving problems and think
              about communication! Hope you got to know my work a bit, and let´s
              work together!
            </p>
          </div>
          <!-- Links of the pages in the website -->
          <div class="col-md-2 col-lg-2 col-xl-2 mx-auto mb-4">
            <h6 class="fw-bold mb-4">Home</h6>
            <p>
              <a href="/#about" class="text-reset">About</a>
            </p>
            <p>
              <a href="/#purpleDiv" class="text-reset">Services</a>
            </p>
            <p>
              <a href="/#msform" class="text-reset">Work with me</a>
            </p>
            <p>
              <a href="/login" class="text-reset">Login</a>
            </p>
            <p>
              <a href="/register" class="text-reset">Register</a>
            </p>
          </div>
          <!-- Links of all social media -->
          <div class="col-md-3 col-lg-2 col-xl-2 mx-auto mb-4">
            <h6 class="fw-bold mb-4">Social Media</h6>
            <p>
              <a href="https://www.instagram.com/" class="text-reset"
                >Instagram</a
              >
            </p>
            <p>
              <a href="https://github.com/" class="text-reset">Github</a>
            </p>
            <p>
              <a href="https://twitter.com/home?lang=pt" class="text-reset"
                >Twitter</a
              >
            </p>
            <p>
              <a href="https://www.youtube.com/" class="text-reset">Youtube</a>
            </p>
            <p>
              <a
                href="https://www.linkedin.com/in/in%C3%AAs-fonseca-5604a51ab/"
                class="text-reset"
                >Linkedin</a
              >
            </p>
            <p>
              <a href="https://www.behance.net/" class="text-reset">Behance</a>
            </p>
          </div>
          <!-- Contact -->
          <div class="col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4">
            <h6 class="fw-bold mb-4">Contact</h6>
            <!-- home icon -->
            <p>
              <svg
                xmlns="http://www.w3.org/2000/svg"
                width="16"
                height="16"
                fill="currentColor"
                class="bi bi-house-door"
                viewBox="0 0 16 16"
              >
                <path
                  d="M8.354 1.146a.5.5 0 0 0-.708 0l-6 6A.5.5 0 0 0 1.5 7.5v7a.5.5 0 0 0 .5.5h4.5a.5.5 0 0 0 .5-.5v-4h2v4a.5.5 0 0 0 .5.5H14a.5.5 0 0 0 .5-.5v-7a.5.5 0 0 0-.146-.354L13 5.793V2.5a.5.5 0 0 0-.5-.5h-1a.5.5 0 0 0-.5.5v1.293L8.354 1.146zM2.5 14V7.707l5.5-5.5 5.5 5.5V14H10v-4a.5.5 0 0 0-.5-.5h-3a.5.5 0 0 0-.5.5v4H2.5z"
                />
              </svg>
              Madeira, Portugal
            </p>
            <!-- email icon -->
            <p>
              <svg
                xmlns="http://www.w3.org/2000/svg"
                width="16"
                height="16"
                fill="currentColor"
                class="bi bi-envelope"
                viewBox="0 0 16 16"
              >
                <path
                  d="M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V4Zm2-1a1 1 0 0 0-1 1v.217l7 4.2 7-4.2V4a1 1 0 0 0-1-1H2Zm13 2.383-4.708 2.825L15 11.105V5.383Zm-.034 6.876-5.64-3.471L8 9.583l-1.326-.795-5.64 3.47A1 1 0 0 0 2 13h12a1 1 0 0 0 .966-.741ZM1 11.105l4.708-2.897L1 5.383v5.722Z"
                />
              </svg>
              ines.a.fonseca@outlook.com
            </p>
          </div>
        </div>
      </div>
    </div>
  </footer>
  <!--******************************************* Footer  Ends *******************************************-->

  <router-view />
</template>



<style>
/* navbar menu index Start*/

.navbar {
  position: relative;
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  justify-content: space-between;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}
.navbar > .container,
.navbar > .container-fluid,
.navbar > .container-sm,
.navbar > .container-md,
.navbar > .container-lg,
.navbar > .container-xl,
.navbar > .container-xxl {
  display: flex;
  flex-wrap: inherit;
  align-items: center;
  justify-content: space-between;
}
.navbar-brand {
  padding-top: 0.3125rem;
  padding-bottom: 0.3125rem;
  margin-right: 1rem;
  font-size: 1.25rem;
  text-decoration: none;
  white-space: nowrap;
}
.navbar-nav {
  display: flex;
  flex-direction: column;
  padding-left: 0;
  margin-bottom: 0;
  list-style: none;
}

.navbar-nav .dropdown-menu {
  position: static;
}

.navbar-text {
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.navbar-collapse {
  flex-basis: 100%;
  flex-grow: 1;
  align-items: center;
}

.navbar-toggler {
  padding: 0.25rem 0.75rem;
  font-size: 1.25rem;
  line-height: 1;
  background-color: transparent;
  border: 1px solid transparent;
  border-radius: 0.25rem;
  transition: box-shadow 0.15s ease-in-out;
}
@media (prefers-reduced-motion: reduce) {
  .navbar-toggler {
    transition: none;
  }
}
.navbar-toggler:hover {
  text-decoration: none;
}

.navbar-light .navbar-toggler-icon {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 30 30'%3e%3cpath stroke='rgba%280, 0, 0, 0.55%29' stroke-linecap='round' stroke-miterlimit='10' stroke-width='2' d='M4 7h22M4 15h22M4 23h22'/%3e%3c/svg%3e");
}

.navbar-dark .navbar-toggler {
  color: blue;
}

#mainNav {
  padding-top: 1rem;
  padding-bottom: 1rem;
  background-color: #f7f3f3;
}
#mainNav .navbar-toggler {
  padding: 0.75rem;
  font-size: 0.75rem;
  font-family: Arial, Helvetica, sans-serif;
  font-weight: 700;
}

#mainNav .navbar-brand img {
  height: 1.5rem;
}

#mainNav .navbar-nav .nav-item .nav-link {
  font-family: Arial, Helvetica, sans-serif;
  font-size: 0.95rem;
  color: blue;
  letter-spacing: 0.0625em;
}

@media (min-width: 992px) {
  #mainNav {
    padding-top: 1.5rem;
    padding-bottom: 1.5rem;
    border: none;
    background-color: transparent;
    transition: padding-top 0.3s ease-in-out, padding-bottom 0.3s ease-in-out;
  }
  #mainNav .navbar-brand {
    font-size: 1.5em;
    transition: font-size 0.3s ease-in-out;
  }
  #mainNav .navbar-brand img {
    height: 2rem;
    transition: height 0.3s ease-in-out;
  }
  #mainNav.navbar-shrink {
    padding-top: 1rem;
    padding-bottom: 1rem;
    background-color: #f7f3f3;
  }
  #mainNav.navbar-shrink .navbar-brand {
    font-size: 1.25em;
  }
  #mainNav.navbar-shrink .navbar-brand svg,
  #mainNav.navbar-shrink .navbar-brand img {
    height: 1.5rem;
  }
  #mainNav .navbar-nav .nav-item {
    margin-right: 1rem;
  }
  #mainNav .navbar-nav .nav-item:last-child {
    margin-right: 0;
  }
}

/*burger menu icon*/
.navbar-light .navbar-toggler-icon {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 30 30'%3e%3cpath stroke='rgba%280, 0, 0, 0.55%29' stroke-linecap='round' stroke-miterlimit='10' stroke-width='2' d='M4 7h22M4 15h22M4 23h22'/%3e%3c/svg%3e");
}

.navbar-light .navbar-text a,
.navbar-light .navbar-text a:hover,
.navbar-light .navbar-text a:focus {
  color: rgba(40, 4, 245, 0.9);
}

#mainNav {
  padding-top: 1rem;
  padding-bottom: 1rem;
  background-color: #f7f3f3;
}
#mainNav .navbar-toggler {
  padding: 0.75rem;
  font-size: 0.75rem;
  font-family: Arial, Helvetica, sans-serif;
  font-weight: 700;
}
#mainNav .navbar-brand {
  color: blue;

  font-weight: 700;
  letter-spacing: 0.0625em;
}
#mainNav .navbar-brand img {
  height: 1.5rem;
}

#mainNav .navbar-nav .nav-item .nav-link {
  font-family: Arial, Helvetica, sans-serif;
  font-size: 0.95rem;
  color: blue;
  letter-spacing: 0.0625em;
}
#mainNav .navbar-nav .nav-item .nav-link.active,
#mainNav .navbar-nav .nav-item .nav-link:hover {
  color: rgb(128, 128, 128);
}

@media (min-width: 992px) {
  #mainNav {
    padding-top: 1.5rem;
    padding-bottom: 1.5rem;
    border: none;
    transition: padding-top 0.3s ease-in-out, padding-bottom 0.3s ease-in-out;
  }
  #mainNav .navbar-brand {
    font-size: 1.5em;
    transition: font-size 0.3s ease-in-out;
  }
  #mainNav .navbar-brand img {
    height: 2rem;
    transition: height 0.3s ease-in-out;
  }
  #mainNav.navbar-shrink {
    padding-top: 1rem;
    padding-bottom: 1rem;
  }
  #mainNav.navbar-shrink .navbar-brand {
    font-size: 1.25em;
  }
  #mainNav.navbar-shrink .navbar-brand svg,
  #mainNav.navbar-shrink .navbar-brand img {
    height: 1.5rem;
  }
  #mainNav .navbar-nav .nav-item {
    margin-right: 1rem;
  }
  #mainNav .navbar-nav .nav-item:last-child {
    margin-right: 0;
  }
}
/*navbar menu index Ends*/

/*footer Starts*/
.footer {
  position: absolute;
  bottom: 0;
  width: 100%;
  height: 0px;
}

/*footer Ends*/
</style>