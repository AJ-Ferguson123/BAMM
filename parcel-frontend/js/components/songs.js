export default function Songs(songs){
  return`
      <ul>
    ${songs.map(song =>{
     return`
        <li>
          <h3>${song.title}</h3>
          <h3>${song.duration}</h3>
          <input class='delete-song_id' type='hidden' value="${song.songId}"/>
          
           <input class='song_title' type='hidden' value='${song.title}'>
          <input class='song_duration' type='hidden' value='${song.duration}'>
          

          <section class='edit-song-box'>
              <input class='edit-song_id' type='hidden' value='${song.songId}'>
              <input class='song_title' type='hidden' value='${song.title}'>
              <input class='song_duration' type='hidden' value='${song.duration}'>
              <button class='edit-song_submit'>Submit</button>
          </section>        
             
             
          <button class='delete-songId_submit button'>Delete</button>

          <input class='single-song_id' type='hidden' value="${song.songId}"/>
          <button class='single-songId_submit button'>Choose Song</button>
          <input class='edit-song_id' type='hidden' value="${song.songId}"/>
          
        </li>
                
`
  }).join("")}
      </ul>

      <section class="add-song">
        <input class="add-song_songtitle" type="text" placeholder="Add a Song!">
        <button class="button">Submit</button>
      </section>
      
      
        `;
}
