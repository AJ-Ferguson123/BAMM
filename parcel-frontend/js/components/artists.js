import imgPrince from "../../images/princeMusician.jpg";
import imageall from "~/images/*";
export default function Artists(artists){
    return`
        <ul>
      ${artists.map(artist =>{
       return`
          <li>
            <h3>${artist.artistName}</h3>
            <h3>${artist.hometown}</h3>
           <img src=${imageall}>
          
            
          </li>
                  
  `
    }).join("")}
        </ul>

        <section class="add-artist">
          <input class="add-artist_artistname" type="text" placeholder="Add an Artist!">
          <button class="add-artist_submit button">Submit</button>

        </section>
          `;
  }