import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { IncidentBrowserComponent } from './incident-browser/incident-browser.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { ProfileComponent } from './profile/profile.component';
import { UnregisterGuard } from './guards/unregister.guard';
import { NotificationComponent } from './notification/notification.component';
import { NotificationAllComponent } from './notification/notification-all/notification-all.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { AddConsumerComponent } from './add-consumer/add-consumer.component';
import { AddDeviceComponent } from './add-device/add-device.component';
import { AddNewDeviceComponent } from './add-new-device/add-new-device.component';
import { AddTeamsComponent } from './add-teams/add-teams.component';
import { SafetyDocumentsComponent } from './safety-documents/safety-documents.component';
import { SafetyDocumentsAddComponent } from './safety-documents-add/safety-documents-add.component';
import { SafetyDocumentsBasicInfoComponent } from './safety-documents-add/safety-documents-basic-info/safety-documents-basic-info.component';
import { SafetyDocumentsHistoryComponent } from './safety-documents-add/safety-documents-history/safety-documents-history.component';
import { SafetyDocumentsMultimediaComponent } from './safety-documents-add/safety-documents-multimedia/safety-documents-multimedia.component';
import { SafetyDocumentsEquipmentComponent } from './safety-documents-add/safety-documents-equipment/safety-documents-equipment.component';
import { SafetyDocumentsChecklistComponent } from './safety-documents-add/safety-documents-checklist/safety-documents-checklist.component';
import { SwitchingPlansComponent } from './switching-plans/switching-plans.component';
import { SwitchingPlansNewComponent } from './switching-plans-new/switching-plans-new.component';


const routes: Routes = [
  {path: '', component: LoginComponent},
  {path: 'dashboard', component: DashboardComponent, canActivate: [UnregisterGuard]},
  {path: 'profile', component: ProfileComponent, canActivate: [UnregisterGuard]},
  {path: 'login', component: LoginComponent},
  {path: 'add-consumer', component: AddConsumerComponent},
  {path: 'notifications', component: NotificationComponent, children: [
    {path: 'notifications-all', component: NotificationAllComponent},
  ]},
  { path: 'safety-documents', component: SafetyDocumentsComponent},
  { path: 'safety-documents-add', component: SafetyDocumentsAddComponent, children: [
    { path: 'safety-documents-basic-info', component: SafetyDocumentsBasicInfoComponent},
    { path: 'safety-documents-history', component: SafetyDocumentsHistoryComponent},
    { path: 'safety-documents-multimedia', component: SafetyDocumentsMultimediaComponent},
    { path: 'safety-documents-equipment', component: SafetyDocumentsEquipmentComponent},
    { path: 'safety-documents-checklist', component: SafetyDocumentsChecklistComponent},
  ]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
