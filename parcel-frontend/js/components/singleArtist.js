export default function SingleArtist(singleArtist){
    return`
        <ul>
        <input class='single-artist_id' type='hidden' value="${singleArtist.artistId}"/>
        <h3>${singleArtist.artistName}</h3>
        <h3>${singleArtist.hometown}</h3>
        <h3>${singleArtist.age}</h3>
        <img src = ${singleArtist.artistImage} alt= "picture of artist"/>
        <input class='single-artist_id' type='hidden' value="${singleArtist.artistId}"/>


      ${singleArtist.albums.map(album =>{
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
                    <input class='single-artist_id' type='hidden' value="${singleArtist.artistId}"/>
            
                  </section>
                  `;
                 }
                