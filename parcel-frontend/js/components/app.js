import Home from './nav';
import Values from './nav';

pageBuild();

function pageBuild(){
   
    home();
    navValues();
}

function home(){
    const body = document.getElementById('body');
    const home = document.getElementById('nav_home');

    home.addEventListener('click', function(){
        body.innerHTML = Home();
    });    
}

function navValues(){
    const valuesButton  = document.querySelector('nav_values');
    valuesButton.addEventListener('click', function(){
      apiActions.getRequest('http://127.0.0.1:5500/', values =>{
          document.querySelector('#app').innerHTML = Values(values);
      })

    })
}