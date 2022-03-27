<!--https://bootsnipp.com/snippets/Qb71-->


<template>
  <div class="error-template">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <!--error page image-->
          <img id="errorImg" src="@/assets/erroPage.gif" />
          <!--error page message-->
          <div>
            <h1>Oops!</h1>
            <h3>Look's like this isn´t the way, let´s go back?</h3>
          </div>
          <div>
            <!--error page button back home-->
            <a class="btn btn-primary btn-xl text-uppercase" href="/">
              Take Me Home
            </a>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
      
   

<style scoped>
@import "@/assets/about.css";

#errorImg {
  width: 50%;
  padding-bottom: 5px;
  margin-bottom: 2%;
  margin-top: -13%;
}

.error-template {
  padding: 20% 15px;
  text-align: center;
  background-color: rgb(255, 255, 248);
}

</style>