import * as CONSTANTS from "../components/constants";
import apiActions from "../api/apiActions";


export default{
    DisplayAllPets
}
export function DisplayAllPets(pets) {
    CONSTANTS.title.innerText ="Pets"
    // apiActions.getRequest(CONSTANTS.PetAPIURL, displayPets);
    // function displayPets(data){
        console.log(pets);
     CONSTANTS.content.innerHTML=
     `
        <ul id="petCards">

            ${pets.map(pet =>{
                console.log(pet);
                return `
                    <li>
                    <div class="card" style="width: 18rem;">
                    <img src="${pet.photo}" class="card-img-top" alt="pet profile">
                    <div class="card-body">
                    <h5 class="card-title">${pet.name}</h5>
                    <a href="#" class="btn btn-primary" id="pet${pet.id}">View Pet</a>
                    </div>
                    </div>
                    </li>
                `
            }).join('')}
            
        </ul>
        <button id="btnAddPet">Add Pet</button>`;
}


