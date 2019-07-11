export default function Values(values){
  return`
      <ul>
  ${values.map(values =>{
   return`
        <li>
          <h3>${value}</h3>
        </li>
`

  })}
      </ul>
`
}