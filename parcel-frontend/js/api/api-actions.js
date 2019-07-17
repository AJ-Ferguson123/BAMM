function getRequest(location, callback){
   console.log(location)
   fetch(location)   
    .then(response => response.json())
    .then(jsonData => callback(jsonData))
    .catch(err => console.log(err))
}

function postRequest(location, requestBody, callback){
   fetch(location,{
       method: "POST",
       headers: {"Content-Type" : "application/json"},
       body: JSON.stringify(requestBody)
   })
   .then(response => response.json())
   .then(jsonData => callback(jsonData))
   .catch(err => console.log(err));
}
export default{
   getRequest,
   postRequest
}