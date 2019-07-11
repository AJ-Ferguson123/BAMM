import Home from './nav';

pageBuild();

function pageBuild(){
    home();
}

function home(){
const body = document.getElementById('body');
const home = document.getElementById('nav_home');

home.addEventListener('click', function(){
    body.innerHTML = Home();
});

}