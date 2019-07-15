import Home from './nav';
import Artists from './artists';
import apiActions from '../api/api-actions';



pageBuild();

function pageBuild(){
    artists();
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
function artists(){
    const artist = document.querySelector('nav_Artists');
    artist.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44358/api/artist', artists =>{
            document.getElementById('body').innerHTML= Artists(artists)
            
        })
    })
}