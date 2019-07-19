export default function Artists(artists){
    return`
        <ul>
      ${artists.map(artist =>{
       return`
          <li>
            <h3>${artist.artistName}</h3>
            <h3>${artist.homeTown}</h3>
            <input class='delete-artist_id' type='hidden' value="${artist.artistId}"/>
            
             <input class='artist_name' type='hidden' value='${artist.artistName}'>
            <input class='artist_hometown' type='hidden' value='${artist.homeTown}'>
            <button class='delete-artistId_submit button'>Delete</button>
          </li>
                  
  `
    }).join("")}
        </ul>

        <section class="add-artist">
          <input class="add-artist_artistname" type="text" placeholder="Add an Artist!">
          <button class="add-artist_submit button">Submit</button>
        </section>
        <section class="delete-artist">
            <input class="delete-artist_artistName" type="text" placeholder= "Delete artist.">
            <button class= "delete-artist_submit">Submit</button>
        </section>

          `;
  }
