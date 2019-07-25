export default function SingleArtist(singleArtist){
 console.log(singleArtist)   
  return`
        <ul>
        <input class='single-artist_id' type='hidden' value="${singleArtist.artistId}"/>
        <h3>${singleArtist.artistName}</h3>
        <h3>${singleArtist.hometown}</h3>
        <h3>${singleArtist.age}</h3>
        <img src = ${singleArtist.artistImage} alt= "picture of artist"/>
        
        

      ${singleArtist.albums.map(album =>{
       return`
          <li>
            <h3>${album.albumTitle}</h3>
            <h3>${album.albumImage}</h3>
            <input class='single-album_id' type='hidden' value="${album.albumId}"/>
            <button class='single-albumId_submit button'>Choose Album</button>

            <input class='deleteartistalbum_id' type='hidden' value="${album.artistId}"/>
            <input class='delete-album_id' type='hidden' value='${album.albumId}'/>
            <input class='delete-albumArtist_id' type='hidden' value=""/>
            <button class='delete-albumId_submit button'>Delete</button>
          </li>`

              }).join("")}
                  </ul>
                <section class="add-album">
                  <input class='add-album_albumid' type='hidden' value='${singleArtist.albumId}'>
                  <input class='add-album_artistid' type='hidden' value='${singleArtist.artistId}'>
                  <input class="add-album_albumtitle" type="text" placeholder="Add an Album Title!">
                  <input class="add-album_label" type="text" placeholder="Add an Album Label!">
                  <input class="add-album_date" type="text" placeholder="Add an Album Date!">
                  <button class="add-album_submit button">Submit</button>
                </section>
                  `;
                 }
                