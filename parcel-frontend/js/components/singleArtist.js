// export function SingleArtist(){
//     return '<p>This is an artist page</p>';
// };

export function SingleArtist(singleArtist){
    return`
        <ul>
        <h3>${singleArtist.artistName}</h3>
        <h3>${singleArtist.hometown}</h3>
        <h3>${aingleArtist.age}</h3>
        <h3>${artist.artistImage}</h3>
        <input class='single-artist_id' type='hidden' value="${artist.artistId}"/>


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
              