import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddUserComponent } from './components/add-user/add-user.component';
import { UserDetailsComponent } from './components/user-details/user-details.component';
import { UserListComponent } from './components/users-list/user-list.component';
import { AddPolicyComponent } from './components/add-policy/add-policy/add-policy.component';
import { PoliciesListComponent } from './components/policies-list/policies-list/policies-list.component';
import { PolicyDetailsComponent } from './components/policy-details/policy-details/policy-details.component';

@NgModule({
  declarations: [
    AppComponent,
    AddUserComponent,
    UserDetailsComponent,
    UserListComponent,
    AddPolicyComponent,
    PoliciesListComponent,
    PolicyDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
