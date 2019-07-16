import Home from './navBar';
import Artists from './artists';
import apiActions from '../api/api-actions';



pageBuild();

function pageBuild(){
    artists();
    home();
}

function home(){
    const body = document.getElementById('root');
    const home = document.getElementById('nav_home');

    home.addEventListener('click', function(){
        body.innerHTML = Home();
    });
}

function artists(){
    const artist = document.getElementById('nav_Artists');
    artist.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44358/api/artists', artists =>{
            console.log(artists)
            document.getElementById('root').innerHTML= Artists(artists)
        })
    })

    

    document.getElementById('root').addEventListener("click", function(){
        if(event.target.classList('add-artist_submit')){
            const artistName = event.target.parentElement.querySelector('.add-artist_artistname').value;
            const data ={
                id: 0,
                ArtistName: artistName
            };
            apiActions.postRequest(
                "https://localhost:44358/api/artists",
                data,
                artists => {
                  document.querySelector("#root").innerHTML = Artists(artists);
                }
              );
        }
    })
}

