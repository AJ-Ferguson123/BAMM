export default function Artists(artists){
    return`
        <ul>
      ${artists.map(artist =>{
       return`
          <li>
            <h3>${artist.artistName}</h3>
            <h3>${artist.hometown}</h3>
            <input class='delete-artist_id' type='hidden' value="${artist}">
            <button class='delete-artistId_submit button'>Delete</button>
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
