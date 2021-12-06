import * as CONSTANTS from "./constants.js";
import owner from "../components/owner";
import pet from "./petProfile";
import pets from "../components/pets";
import weight from "../components/weight";
import authorizedUser from "../components/authorizedUser";
import medicalItem from "../components/medicalItem";
import medicalRecord from "../components/medicalRecord";
import apiActions from "../api/apiActions";
import about from "../components/about";


export default {
    SetupNavBar,
    SetupAboutNav,
    SetupOwner,
    SetupPetNav
}

export function SetupNavBar() {
    SetupPets();
    return `
    <ul> 
        <li id="navPets">Pets</li>
        <li id="navOwner">Owner</li>
        <li id="navAbout">About</li>
    </ul>
    `;
}

function SetupPets() {
    apiActions.getRequest(CONSTANTS.PetAPIURL, data => {
        pets.DisplayAllPets(data);
        pets.SetupPetLinks();
    });
}

export function SetupOwner() {
    const ownerLink = document.getElementById('navOwner');

    ownerLink.addEventListener("click", function () {
         apiActions.getRequest(CONSTANTS.OwnerAPIURL+"1", data => {
        console.log("owner button clicked");
        CONSTANTS.content.innerHTML = owner.DisplayOwner(data);
        CONSTANTS.title.innerText = "";
        owner.SetupEditOwnerButton(data);
    })

    })}

     function SetupPetNav(){
        const petLink = document.getElementById('navPets');
        petLink.addEventListener("click", function(){
            SetupPets()
        })
     }

     function SetupAboutNav(){
        const aboutLink = document.getElementById('navAbout');
        aboutLink.addEventListener("click", function(){
            about.SetupAbout();
            
        })
    }

  