import Home from './navBar';
import Artists from './artists';
import apiActions from '../api/api-actions';
import Albums from './albums';
//import Comments from './comments';
//import Tags from './tags';
//import Songs from './songs'


pageBuild();

function pageBuild(){
    artists();
    home();
    albums();

       //();
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
            console.log(artists)
            document.getElementById('root').innerHTML= Artists(artists)
        })
    })

    document.getElementById('root').addEventListener('click', function(){
        if(event.target.classList.contains('add-artist_submit')){
            const artistName = event.target.parentElement.querySelector('.add-artist_name').value;
            const data ={
                id: 0,
                ArtistName: artistName
            };
            apiActions.postRequest(
                'https://localhost:44358/api/artists',
                data,
                artists => {
                  document.querySelector('#root').innerHTML = Artists(artists);
                }
              );
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
 
      // document.addEventListener('click', function() {
      //   if (event.target.classList.contains('edit-artistId_button')) {
      //     console.log("event triggered"); 
      //     console.log(event.target.parentElement);
      //     const artist = event.target.parentElement.querySelector('.edit-artist_id').value;
  
      //     console.log(artist);
      //     const data = {
      //       ArtistId: artist
            
      //     }
      //     apiActions.putRequest('https://localhost:44358/api/artists',
      //       data,
      //       artists => {
      //         console.log(artists);
      //         document.querySelector('#root').innerHTML = Artists(artists);
      //       });
//};
  
function albums(){
    const album = document.getElementById('nav_Albums');
    console.log(album)
    album.addEventListener('click', function(){
            console.log("album="+album)
            apiActions.getRequest('https://localhost:44358/api/albums', albums =>{
            console.log(albums)
            document.getElementById('root').innerHTML= Albums(albums)
        })
    });

    document.getElementById('root').addEventListener('click', function(){
        if(event.target.classList.contains('add-artist_submit')){
            const albumTitle = event.target.parentElement.querySelector('.add-album_albumtitle').value;
            const data ={
                id: 0,
                AlbumTitle: albumTitle
            };
            apiActions.postRequest('https://localhost:44358/api/albums',
                data,
                albums => {
                  document.querySelector('#root').innerHTML = Albums(albums);
                });
            }
        });

        document.addEventListener('click', function() {
            if (event.target.classList.contains('delete-albumId_submit')) {
              console.log("delete event triggered");                  
              const album = event.target.parentElement.querySelector('.delete-album_id').value;
    
              console.log("just before delete request"+album)
              const data = {
                AlbumId: album
              
              };
              console.log(data);
              apiActions.deleteRequest('https://localhost:44358/api/albums',
                data,
                albums => {
                  console.log(albums);
                  document.querySelector('#root').innerHTML = Albums(albums);
                });
            }
          });
    };
     
    
    

    
    //post request end
    // function songs(){
    //                  const song = document.getElementById('nav_Songs');
    //                  song.addEventListener('click', function(){
    //                  apiActions.getRequest('https://localhost:44358/api/songs', songs =>{
    //                  console.log(songs)
    //                  document.getElementById('root').innerHTML= Songs(songs)
    //                 })
    //             })
            
                
            
    //             document.getElementById('root').addEventListener("click", function(){
    //                 if(event.target.classList.contains('add-song_submit')){
    //                     const songName = event.target.parentElement.querySelector('.add-song_songname').value;
    //                     const data ={
    //                         id: 0,
    //                         SongName: songName
    //                     };
    //                     apiActions.postRequest(
    //                         "https://localhost:44358/api/songs",
    //                         data,
    //                         songs => {
    //                           document.querySelector("#root").innerHTML = Songs(songs);
    //                         }
    //                       );
                          
// function comments(){
//                     const comment = document.getElementById('nav_Comments');
//                     comment.addEventListener('click', function(){
//                     apiActions.getRequest('https://localhost:44358/api/comments', comments =>{
//                      console.log(comments)
//                     document.getElementById('root').innerHTML= Comments(comments)
//                   })
//     })

    

//     document.getElementById('root').addEventListener("click", function(){
//         if(event.target.classList.contains('add-comment_submit')){
//             const commentName = event.target.parentElement.querySelector('.add-comment_commentname').value;
//             const data ={
//                 id: 0,
//                 CommentName: commentName
//             };
//             apiActions.postRequest(
//                 "https://localhost:44358/api/comments",
//                 data,
//                 comments => {
//                   document.querySelector("#root").innerHTML = Comments(comments);
//                 },
//     function tags(){
//          const tag = document.getElementById('nav_Tags');
//                 tag.addEventListener('click', function(){
//                 apiActions.getRequest('https://localhost:44358/api/tags', tagss =>{
//                 console.log(tags)
//                 document.getElementById('root').innerHTML= Artists(tags)
//                         })
//                     })
                
                    
                
//         document.getElementById('root').addEventListener("click", function(){
//          if(event.target.classList.contains('add-tag_submit')){
//         const tagName = event.target.parentElement.querySelector('.add-tag_artistname').value;
//         const data ={
//                      id: 0,
//                      TagName: tagName
//                     };
//          apiActions.postRequest(
//          "https://localhost:44358/api/tags",
//          data,
//         tags => {
//                     document.querySelector("#root").innerHTML = Tags(tags);
//                 }
//                                 );
//         }
//                     })
//                 }
//               );
//         }
//     })
// }

            //         }
            //     })
            // }        
  
  
