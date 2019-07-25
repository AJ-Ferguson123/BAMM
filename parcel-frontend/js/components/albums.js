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

            

            
            </li>
            
            `
        }).join("")}
        </ul>
         
          `;
  }