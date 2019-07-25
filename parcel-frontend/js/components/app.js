import Home from './Home';
import Artists from './artists';
import apiActions from '../api/api-actions';
import SingleArtist from './singleArtist';
import Albums from './albums';
import SingleAlbum from './singleAlbum';
//import Comments from './comments';
//import Tags from './tags'
import Songs from './songs'

pageBuild();

function pageBuild(){
    artists();
    home();
    singleArtist();
    albums();
    singleAlbum();
     songs();
   // comment();
   // tags();
}

function home(){
    const body = document.getElementById('root');
    const home = document.getElementById('nav_home');

    home.addEventListener('click', function(){
        body.innerHTML = Home();
    });
};

function artists(){
    const artist = document.getElementById('nav_Artists');
    artist.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44358/api/artists', artists =>{
        document.getElementById('root').innerHTML= Artists(artists)
        })
    })

    document.getElementById('root').addEventListener('click', function(){
        if(event.target.classList.contains('add-artist_submit')){
            const artistName = event.target.parentElement.querySelector('.add-artist_name').value;
            const hometown = event.target.parentElement.querySelector('.add-artist_hometown').value;
            const data ={
                artistId: 0,
                ArtistName: artistName,
                Hometown: hometown
            };
            apiActions.postRequest(
                'https://localhost:44358/api/artists',
                data,
                artists => {
                  document.querySelector('#root').innerHTML = Artists(artists);
                });
        }
    });

    document.addEventListener('click', function() {
        if (event.target.classList.contains('delete-artistId_submit')) {
          console.log("event triggered");
          
          const artist = event.target.parentElement.querySelector('.delete-artist_id').value;
          console.log(artist)
          const data = {
            ArtistId: artist
          };      
          console.log(data);

          apiActions.deleteRequest(
            'https://localhost:44358/api/artists',
            data,
            artists => {
              console.log(artists);
              document.querySelector('#root').innerHTML = Artists(artists);
            }
          );
        }
      });

    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('edit-artist_submit')){
            console.log('event triggered');
            const editartist_id = event.target.parentElement.querySelector('.edit-artist_id').value;
            const editartist_name = event.target.parentElement.querySelector('.edit-artist_name').value;
            const editartist_hometown = event.target.parentElement.querySelector('.edit-artist_hometown').value;
            console.log(editartist_id)
            console.log(editartist_name)
            console.log(editartist_hometown)
            const data = {
                ArtistId: editartist_id,
                ArtistName: editartist_name,
                Hometown: editartist_hometown
            };
            console.log(data);
            apiActions.putRequest('https://localhost:44358/api/artists', data, artists => {
                    console.log("list of artists from controller: " + artists);
                    document.querySelector('#root').innerHTML = Artists(artists);
                }
            );
        }
  });
};
 

function singleArtist(){
  document.addEventListener('click', function() {
    if (event.target.classList.contains('single-artistId_submit')) {
      console.log("event triggered");
      
      const artistId = event.target.parentElement.querySelector('.single-artist_id').value;
      console.log(artistId)
      console.log(artistId);

      apiActions.getRequest(
        'https://localhost:44358/api/artists/' + artistId,
        artist => {
          console.log("checking artist")
          console.log(artist);
          document.querySelector('#root').innerHTML = SingleArtist(artist);
        });
    }
  });
  document.getElementById('root').addEventListener('click', function(){
    if(event.target.classList.contains('add-album_submit')){
         const date = event.target.parentElement.querySelector('.add-album_date').value;
         const label = event.target.parentElement.querySelector('.add-album_label').value;
         const artistId = event.target.parentElement.querySelector('.add-album_artistid').value;
         const albumTitle = event.target.parentElement.querySelector('.add-album_albumtitle').value;
         const data ={
        albumId: 0,
        albumTitle: albumTitle,
        artistId: artistId,
        label: label,
        date: date
         };
         console.log(data)
         apiActions.postRequest('https://localhost:44358/api/albums/', 
             data,
             artist => {
               document.querySelector('#root').innerHTML = SingleArtist(artist);
             });
         }
     });

     document.addEventListener('click', function() {
      if (event.target.classList.contains('delete-albumId_submit')) {
        console.log("event triggered");
        //const artistId = event.target.parentElement.querySelector('.deleteartistalbum_id').value;
        const album = event.target.parentElement.querySelector('.delete-album_id').value;
        const artistId = event.target.parentElement.querySelector('.deleteartistalbum_id').value
            const data= {
            albumId: album,
            artistId: artistId
          }
      
        apiActions.deleteRequest('https://localhost:44358/api/albums/',
          data,
          artists => {
            console.log(artists);
            document.querySelector('#root').innerHTML = SingleArtist(artists);
          });
         }
   });
   document.getElementById('root').addEventListener('click', function(){
    if (event.target.classList.contains('edit-artist_submit')){
        console.log('event triggered');
        const editartist_id = event.target.parentElement.querySelector('.edit-artist_id').value;
        const editartist_name = event.target.parentElement.querySelector('.edit-artist_name').value;
        const editartist_hometown = event.target.parentElement.querySelector('.edit-artist_hometown').value;
        console.log(editartist_id)
        console.log(editartist_name)
        console.log(editartist_hometown)
        const data = {
            ArtistId: editartist_id,
            ArtistName: editartist_name,
            Hometown: editartist_hometown
        };
        console.log(data);
        apiActions.putRequest('https://localhost:44358/api/artists', data, artists => {
                console.log("list of artists from controller: " + artists);
                document.querySelector('#root').innerHTML = Artists(artists);
            }
        );
    }
});
};

  
      
function albums(){
  const album = document.getElementById('nav_Albums');
     album.addEventListener('click', function(){
         apiActions.getRequest('https://localhost:44358/api/albums', 
         albums =>{
           console.log(albums)
             document.getElementById('root').innerHTML= Albums(albums)
         });
     });
     

         
  };


function singleAlbum(){
     document.querySelector('#root').addEventListener("click", function() {
          if (event.target.classList.contains("single-albumId_submit")) {
            const albumId = event.target.parentElement.querySelector(".single-album_id").value;
              console.log(albumId)
            apiActions.getRequest("https://localhost:44358/api/albums/"+ albumId,
              album => {
                  document.querySelector('#root').innerHTML = SingleAlbum(album);
              });
          }
        });
  }
    
    
function songs(){
      const song = document.getElementById('nav_Songs');
        song.addEventListener('click', function(){
          apiActions.getRequest('https://localhost:44358/api/songs', 
          songs =>{
                  console.log(songs)
                  document.getElementById('root').innerHTML= Songs(songs)
                })
              })
            
          document.getElementById('root').addEventListener("click", function(){
            if(event.target.classList.contains('add-song_submit')){
              const title = event.target.parentElement.querySelector('.add-song_title').value;
                const data ={
                    id: 0,
                    Title: title
                };
                  apiActions.postRequest(
                    "https://localhost:44358/api/songs",
                      data,
                      songs => {
                        document.querySelector("#root").innerHTML = Songs(songs);
                      });
                }});

          document.addEventListener('click', function() {
            if (event.target.classList.contains('delete-songId_submit')) {
              console.log("event triggered");
                            
                const song = event.target.parentElement.querySelector('.delete-song_id').value;
                  console.log(song)
                    const data = {
                      SongId: song
                    };      
                  console.log(data);
                  
                apiActions.deleteRequest(
                    'https://localhost:44358/api/songs',
                       data,
                       songs => {
                        console.log(songs);
                          document.querySelector('#root').innerHTML = Songs(songs);
                        });
                    }
                  });

            document.getElementById('root').addEventListener('click', function(){
             if (event.target.classList.contains('edit-song_submit')){
                 console.log('event triggered');
                   const editsong_id = event.target.parentElement.querySelector('.edit-song_id').value;
                   const editsong_title = event.target.parentElement.querySelector('.edit-song_title').value;
                   const editsong_duration = event.target.parentElement.querySelector('.edit-song_duration').value;
                      console.log(editsong_id)
                      console.log(editsong_title)
                      console.log(editsong_duration)
                        const data = {
                          SongId: editsong_id,
                          SongTitle: editsong_title,
                          Duration: editsong_duration
                        };
                      console.log(data);
                        apiActions.putRequest('https://localhost:44358/api/songs', data, 
                        songs => {
                          console.log("list of songs from controller: " + songs);
                             document.querySelector('#root').innerHTML = Songs(songs);
                           });
                         }
                      });
};
                          

      
