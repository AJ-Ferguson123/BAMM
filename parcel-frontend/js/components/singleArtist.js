

export default function SingleArtist(singleArtist){
    return`
        <ul>
        <h3>${singleArtist.artistName}</h3>
        <h3>${singleArtist.hometown}</h3>
        <h3>${singleArtist.age}</h3>
        <h3>${singleArtist.artistImage}</h3>
        <input class='single-artist_id' type='hidden' value="${singleArtist.artistId}"/>


      ${singleArtist.map(album =>{
       return`
          <li>
            <h3>${album.albumTitle}</h3>
            <h3>${album.albumImage}</h3>
            <input class='album_id' type='hidden' value="${album.albumId}"/>
            <button class='albumId_submit button'>Choose Album</button>


            </li>
                  
            `
              }).join("")}
                  </ul>
                  `;
                }
              