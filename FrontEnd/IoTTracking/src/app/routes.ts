import { Routes } from "@angular/router";
import { DeviceSettingModalComponent } from "./deviceSettings/deviceSettingModal/deviceSettingModal.component";
import { DeviceSettingsComponent } from "./deviceSettings/DeviceSettings.component";
import { PersonsComponent } from "./persons/persons.component";
export const appRoutes:Routes=[
    {path:"",component:DeviceSettingsComponent},
    {path:"deviceSettings",component:DeviceSettingsComponent},
    {path:"persons",component:PersonsComponent},
    {path:"deviceSettingModal",component:DeviceSettingModalComponent}
]
    