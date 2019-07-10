import Home from './components/nav';


pageBuild();

function pageBuild(){
   
    home();
}

function home(){
    const home = document.querySelector('.nav_home');
    
    home.addEventListener('click', function(){
        const app = document.getElementById('app');
        app.innerHTML = Home();
    } )
}