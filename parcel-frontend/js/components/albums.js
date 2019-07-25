export default function Albums(albums){
    return`
        <ul>
       
      ${albums.map(album =>{
       return`
          <li>
            <h3>${album.albumTitle}</h3>
            <h3>${album.label}</h3>            
            <h3>${album.date}</h3>
            <img src=${album.albumImage} alt="picture of album cover"/>

            

            <section class='edit-album-box'>
                    <input class='edit-album_id' type='hidden' value='${album.albumId}'>
                    <input class='edit-album_title' type='text' value='${album.albumTitle}'>
                    <input class='edit-album_label' type='text' value='${album.label}'>
                    <input class='edit-album_date' type='text' value='${album.date}'>
                    <button class='edit-album_submit'>Submit</button>
                </section>
            </li>
            
            `
        }).join("")}
        </ul>
         
          `;
  }