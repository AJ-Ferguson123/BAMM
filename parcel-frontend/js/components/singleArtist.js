export default function SingleArtist(singleArtist){
 console.log(singleArtist)   
  return`
        <ul>
        <input class='single-artist_id' type='hidden' value="${singleArtist.artistId}"/>
        <h3>${singleArtist.artistName}</h3>
        <h4>${singleArtist.hometown}</h4>
        <h4>${singleArtist.age}</h4>
        <img src = ${singleArtist.artistImage} alt= "picture of artist"/>
        <input class='single-artist_id' type='hidden' value="${singleArtist.artistId}"/>


      ${singleArtist.albums.map(album =>{
       return`
          <li>
            <h3>${album.albumTitle}</h3>
            <h3>${album.albumImage}</h3>
            <input class='single-album_id' type='hidden' value="${album.albumId}"/>
            <button class='single-albumId_submit button'>Choose Album</button>
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
                