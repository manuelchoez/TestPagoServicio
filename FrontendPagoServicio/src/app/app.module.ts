import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UsuarioModels } from './models/usuario/usuario.models';
import { Usuario } from './models/usuario.model/usuario.model.models';
import { Usuario } from './models/usuario.model/usuario.model.model';

@NgModule({
  declarations: [
    AppComponent,
    UsuarioModels,
    Usuario.ModelModels,
    Usuario.ModelModel
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
