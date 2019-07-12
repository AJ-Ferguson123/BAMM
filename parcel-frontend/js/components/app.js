import Home from './navBar';
import Artists from './artists';
import apiActions from '../api/api-actions';



pageBuild();

function pageBuild(){
    artists();
    home();
}

function home(){
    const body = document.getElementById('body');
    const home = document.getElementById('nav_home');

    home.addEventListener('click', function(){
        body.innerHTML = Home();
    });
    
}
function artists(){
    const artist = document.getElementById('nav_Artists');
    artist.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44358/api/artist', artists =>{
            document.getElementById('body').innerHTML= Artists(artists)
            
        })
    })
}