export default function Artists(artists){
    return`
        <ul>
      ${artists.map(artist =>{
       return`
          <li>
            <h3>${artist.artistName}</h3>
            <h3>${artist.hometown}</h3>
            <input class='delete-artist_id' type='hidden' value="${artist.artistId}"/>
            
             <input class='artist_name' type='hidden' value='${artist.artistName}'>
            <input class='artist_hometown' type='hidden' value='${artist.hometown}'>
            <button class='delete-artistId_submit button'>Delete</button>

            <input class='single-artist_id' type='hidden' value="${artist.artistId}"/>
            <button class='single-artistId_submit button'>Choose Artist</button>
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
