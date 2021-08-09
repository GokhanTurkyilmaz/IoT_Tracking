import { Routes } from "@angular/router";
import { DeviceSettingsComponent } from "./deviceSettings/DeviceSettings.component";
import { PersonsComponent } from "./persons/persons.component";
export const appRoutes:Routes=[
    {path:"",component:DeviceSettingsComponent},
    {path:"deviceSettings",component:DeviceSettingsComponent},
    {path:"persons",component:PersonsComponent}
]
    