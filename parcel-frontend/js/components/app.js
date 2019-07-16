import Home from './navBar';
import Artists from './artists';
import apiActions from '../api/api-actions';
import Albums from './albums';


pageBuild();

function pageBuild(){
    artists();
    home();
    albums();
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
        if(event.target.classList.contains('add-artist_submit')){
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

function albums(){
    const album = document.getElementById('nav_Albums');
    album.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44358/api/albums', albums =>{
            console.log(albums)
            document.getElementById('root').innerHTML= Albums(albums)
        })
    })

    

    document.getElementById('root').addEventListener("click", function(){
        if(event.target.getElementById.contains('add-album_submit')){
            const albumTitle = event.target.parentElement.querySelector('.add-album_albumtitle').value;
            const data ={
                id: 0,
                AlbumTitle: albumTitle
            };
            apiActions.postRequest(
                "https://localhost:44358/api/albums",
                data,
                albums => {
                  document.querySelector("#root").innerHTML = Albums(albums);
                }
              );            
        }
    })
}

