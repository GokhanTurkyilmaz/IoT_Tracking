import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import {appRoutes} from './routes'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './navBar/navBar.component';
import { DeviceSettingsComponent } from './deviceSettings/DeviceSettings.component';
import { PersonsComponent } from './persons/persons.component';
import { TagsComponent } from './tags/tags.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [					
    AppComponent,
      NavBarComponent,
      DeviceSettingsComponent,
      PersonsComponent,
      TagsComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
