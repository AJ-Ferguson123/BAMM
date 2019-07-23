export default function Artists(artists){
    return`
        <ul>
      ${artists.map(artist =>{
       return`
          <li>
            <h3>${artist.artistName}</h3>
            <h3>${artist.hometown}</h3>
            <img src = ${artist.artistImage} alt= "picture of artist"/>
            <input class='delete-artist_id' type='hidden' value="${artist.artistId}"/>
            
             <input class='artist_name' type='hidden' value='${artist.artistName}'>
            <input class='artist_hometown' type='hidden' value='${artist.hometown}'>
            

            <section class='edit-artist-box'>
                <input class='edit-artist_id' type='hidden' value='${artist.artistId}'>
                <input class='edit-artist_name' type='text' value='${artist.artistName}'>
                <input class='edit-artist_hometown' type='text' value='${artist.hometown}'>
                <button class='edit-artist_submit'>Submit</button>
            </section>
   
   

           <input class='artist_id' type='hidden' value='${artist.artistName}'>
           <input class='artist_name' type='hidden' value='${artist.artistName}'>
           <input class='artist_hometown' type='hidden' value='${artist.hometown}'>
               
               
            <button class='delete-artistId_submit button'>Delete</button>

            <input class='single-artist_id' type='hidden' value="${artist.artistId}"/>
            <button class='single-artistId_submit button'>Choose Artist</button>
            <input class='edit-artist_id' type='hidden' value="${artist.artistId}"/>
            
          </li>
                  
  `
    }).join("")}
        </ul>

        <section class="add-artist">
          <input class="add-artist_artistname" type="text" placeholder="Add an Artist!">
          <button class="button">Submit</button>
        </section>
        
        
          `;
  }
