export default function Comments(comments){
    return`
        <ul>
      ${comments.map(comment =>{
       return`
          <li>
            <h3>${comment.commentId}</h3>
            <h3>${comment.commentdetails}</h3>
          </li> 
  `
  
    })}
        </ul>

        <section class="add-comment">
          <input class="add-comment_commentdetails" type="text" placeholder="Add a comment!">
          <button class="button" id="add-comment">Submit</button>

        </section>
          `;
  }