export default function Albums(albums){
    return`
        <ul>
       
      ${albums.map(album =>{
        
       return`
          <li>
            <h3>${album.albumTitle}</h3>
            <h3>${album.label}</h3>
            <h3>${album.albumImage}</h3>
            <h3>${album.date}</h3>
            <input class='delete-album_id' type='hidden' value="${album.albumId}"/>
            <button class='delete-albumId_submit button'>Delete</button>
            <section class="add-album">
          <input class="add-album_albumtitle" type="text" placeholder="Add an Album!">
          <button class="button" id="add-album_submit">Submit</button>

        </section>
          </li>
          
          `
        })
        .join("")}
        </ul>
          
        <section class="add-album">
          <input class="add-album_albumtitle" type="text" placeholder="Add an Album!">
          <button class="add-album_submit button">Submit</button>

        </section>
          `;
  }