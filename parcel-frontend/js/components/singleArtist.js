<<<<<<< HEAD


export default function SingleArtist(singleArtist){
=======
export default function SingleArtist(singleArtist){
  console.log("in single artist component");
>>>>>>> 66486244940ec0277d6fa9b97f8e0404b2dcb2d0
    return`
        <ul>
        <input class='single-artist_id' type='hidden' value="${singleArtist.artistId}"/>
        <h3>${singleArtist.artistName}</h3>
        <h3>${singleArtist.hometown}</h3>
        <h3>${singleArtist.age}</h3>
        <h3>${singleArtist.artistImage}</h3>
<<<<<<< HEAD
        <input class='single-artist_id' type='hidden' value="${singleArtist.artistId}"/>
=======
>>>>>>> 66486244940ec0277d6fa9b97f8e0404b2dcb2d0


      ${singleArtist.albums.map(album =>{
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
              