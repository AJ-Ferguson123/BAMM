export default function SingleSong(singleSong){
    return`
        <ul>
        <input class='single-song_id' type='hidden' value="${singleSong.songId}"/>
        <h3>${singleSong.songTitle}</h3>
        <h3>${singleSong.duration}</h3>
        <input class='single-song_id' type='hidden' value="${singleSong.songId}"/>


      ${singleSong.Comments.map(comment =>{
       return`
          <li>
            <h3>${comment.commentDetails}</h3>
            <input class='comment_id' type='hidden' value="${comment.commentId}"/>
          </li>`
                  
            
              }).join("")}
                  </ul>
                  <section class="add-song">        
                  <input class="add-comment_commentdetail" type="text" placeholder="Add a Comment!">
                  <button class="add-comment_submit">Submit</button>
            
                </section>
                  `;
                 }
                