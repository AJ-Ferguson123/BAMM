export default function Tags(tags){
    return`
        <ul>
      ${tags.map(tag =>{
       return`
          <li>
            <h3>${tag.tagid}</h3>
            <h3>${tag.tagtitle}</h3>
          </li> 
  `
  
    })}
        </ul>

        <section class="add-tag">
          <input class="add-tag_tagname" type="text" placeholder="Add a tag!">
          <button class="button" id="add-tag">Submit</button>

        </section>
          `;
  }