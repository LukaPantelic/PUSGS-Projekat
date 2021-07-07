import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ToastrModule } from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ProfileComponent } from './profile/profile.component';
import { IncidentBrowserComponent } from './incident-browser/incident-browser.component';
import { NotificationComponent } from './notification/notification.component';
import { NotificationAllComponent } from './notification/notification-all/notification-all.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UnregisterGuard } from './guards/unregister.guard';
import { WorkerGuard } from './guards/worker.guard';
import { AuthInterceptor } from './authInterceptor';
import { AddConsumerComponent } from './add-consumer/add-consumer.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    LoginComponent,
    RegisterComponent,
    ProfileComponent,
    IncidentBrowserComponent,
    NotificationComponent,
    NotificationAllComponent,
    SidebarComponent,
    AddConsumerComponent
  ],
  imports: [
    HttpClientModule,
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    ToastrModule.forRoot(),

  ],
  providers: [
    UnregisterGuard,
    WorkerGuard,
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true},
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
