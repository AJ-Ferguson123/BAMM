 
 export default function Songs(songs){
    return`
        <ul>
      ${songs.map(song =>{
       return`
          <li>
            <h3>${song.title}</h3>
            <h3>${song.duration}</h3>
          </li> 
  `
  
    })}
        </ul>

        <section class="add-song">
          <input class="add-song_songname" type="text" placeholder="Add a song!">
          <button class="button" id="add-song">Submit</button>

        </section>
          `;
  }