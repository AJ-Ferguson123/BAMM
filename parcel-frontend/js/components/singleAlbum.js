export default function SingleAlbum(singleAlbum, artistId){
    return`
        <ul>
        <input class='single-album_id' type='hidden' value="${singleAlbum.albumId}"/>
        <h3>${singleAlbum.albumTitle}</h3>
        <h3>${singleAlbum.albumImage}</h3>
        <h4>${singleAlbum.label}</h4>
        <h5>${singleAlbum.date}</h5>
        <input class='single-album_id' type='hidden' value="${singleAlbum.albumId}"/>

      ${singleAlbum.songs.map(song =>{
       return`
          <li>
            <h3>${song.title}</h3>
            <h4>${song.duration}</h4>
            <input class='song_id' type='hidden' value="${song.songId}"/>
            <button class='songId_submit button'>Choose Song</button>
            </li>`
                              
              }).join("")}
                  </ul>
                  <section class="add-song">        
                  <input class="add-song_songtitle" type="text" placeholder="Add a song!">
                  <button class="add-song_submit" id="add-song_submit">Submit</button>            
                </section>
                  `;
                 }