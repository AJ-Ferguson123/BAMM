export default function SingleAlbum(singleAlbum){
  return`
    <ul>
      <input class='single-album_id' type='hidden' value="${singleAlbum.albumId}"/>
      <h3>${singleAlbum.albumTitle}</h3>
      <img src= ${singleAlbum.albumImage} alt="picture of album"/>
      <h3>${singleAlbum.label}</h3>
      <h3>${singleAlbum.date}</h3>
      <input class='single-album_id' type='hidden' value="${singleAlbum.albumId}"/>

    ${singleAlbum.songs.map(song =>{
      return`
        <li>
          <h3>${song.title}</h3>
          <h3>${song.duration}</h3>
          <input class='song_id' type='hidden' value="${song.songId}"/>
          <button class='songId_submit button'>Choose Song</button>

          <input class='delete-song_id' type='hidden' value='${song.songId}'/>
          <button class='delete-songId_submit button'>Delete</button>

          <section class='edit-song-box'>
              <input class='edit-song_id' type='hidden' value='${song.songId}'>
              <input class='edit-song_title' type='text' value='${song.title}'>
              <input class='edit-song_duration' type='text' value='${song.duration}'>
              <button class='edit-artist_submit'>Submit</button>
          </section>

        </li>`
                              
      }).join("")}
      </ul>
          <section class="add-song">     
              <input class='add-song_songid' type='hidden' value='${singleAlbum.songId}'>
              <input class='add-song_albumid' type='hidden' value='${singleAlbum.albumId}'>
              <input class="add-song_title" type="text" placeholder="Add a Song Title">
              <input class="add-song_duration" type="text" placeholder="Add Song Duration">
              <button class="add-song_submit" id="add-song_submit">Submit</button>            
          </section>
                  `;
                 }