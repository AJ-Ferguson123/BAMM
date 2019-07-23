export default function SingleSong(singleSong){
    return`
        <ul>
        <input class='single-song_id' type='hidden' value="${singleSong.songId}"/>
        <h3>${singleSong.songTitle}</h3>
        <h3>${singleSong.duration}</h3>
        <input class='single-song_id' type='hidden' value="${singleSong.songId}"/>


      ${singleSong.songs.map(song =>{
       return`
          <li>
            <h3>${album.albumTitle}</h3>
            <h3>${album.albumImage}</h3>
            <input class='album_id' type='hidden' value="${album.albumId}"/>
            <button class='albumId_submit button'>Choose Album</button>


            </li>`
                  
            
              }).join("")}
                  </ul>
                  <section class="add-album">        
                  <input class="add-album_albumtitle" type="text" placeholder="Add an Album!">
                  <button class="add-album_submit" id="add-album_submit">Submit</button>
            
                </section>
                  `;
                 }
                