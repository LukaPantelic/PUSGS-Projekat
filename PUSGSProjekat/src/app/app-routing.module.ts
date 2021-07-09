import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { IncidentBrowserComponent } from './incident-browser/incident-browser.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { ProfileComponent } from './profile/profile.component';
import { IncidentNewComponent } from './incident-new/incident-new.component';
import { IncidentBasicInfoComponent } from './incident-new/basic-information/incident-basic-information.component';
import { IncidentDevicesComponent } from './incident-new/incident-devices/incident-devices.component';
import { IncidentResolutionComponent } from './incident-new/incident-resolution/incident-resolution.component';
import { IncidentCallsComponent } from './incident-new/incident-calls/incident-calls.component';
import { IncidentCrewComponent } from './incident-new/incident-crew/incident-crew.component';
import { IncidentMultimediaComponent } from './incident-new/incident-multimedia/incident-multimedia.component';
import { IncidentEquipmentComponent } from './incident-new/incident-equipment/incident-equipment.component';
import { WorkRequestsComponent } from './work-requests/work-requests.component';
import { WorkRequestsNewComponent } from './work-requests-new/work-requests-new.component';
import { WorkRequestsBasicInfoComponent } from './work-requests-new/work-requests-basic-info/work-requests-basic-info.component';
import { WorkRequestsHistoryComponent } from './work-requests-new/work-requests-history/work-requests-history.component';
import { WorkRequestsMultimediaComponent } from './work-requests-new/work-requests-multimedia/work-requests-multimedia.component';
import { WorkRequestsEquipmentComponent } from './work-requests-new/work-requests-equipment/work-requests-equipment.component';
import { UnregisterGuard } from './guards/unregister.guard';
import { WorkerGuard } from './guards/worker.guard';
import { NotificationsComponent } from './notification/notifications.component';
import { NotificationsAllComponent } from './notification/notifications-all/notifications-all.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { AddConsumerComponent } from './add-consumer/add-consumer.component';
import { AddDeviceComponent } from './add-device/add-device.component';
import { AddNewDeviceComponent } from './add-new-device/add-new-device.component';
import { AddTeamComponent } from './add-team/add-team.component';
import { SafetyDocumentsComponent } from './safety-documents/safety-documents.component';
import { SafetyDocumentsAddComponent } from './safety-documents-add/safety-documents-add.component';
import { SafetyDocumentsBasicInfoComponent } from './safety-documents-add/safety-documents-basic-info/safety-documents-basic-info.component';
import { SafetyDocumentsHistoryComponent } from './safety-documents-add/safety-documents-history/safety-documents-history.component';
import { SafetyDocumentsMultimediaComponent } from './safety-documents-add/safety-documents-multimedia/safety-documents-multimedia.component';
import { SafetyDocumentsEquipmentComponent } from './safety-documents-add/safety-documents-equipment/safety-documents-equipment.component';
import { SafetyDocumentsChecklistComponent } from './safety-documents-add/safety-documents-checklist/safety-documents-checklist.component';
import { SwitchingPlansComponent } from './switching-plans/switching-plans.component';
import { SwitchingPlansNewComponent } from './switching-plans-new/switching-plans-new.component';
import { SwitchingPlansBasicInfoComponent } from './switching-plans-new/switching-plans-basic-info/switching-plans-basic-info.component';
import { SwitchingPlansHistoryComponent } from './switching-plans-new/switching-plans-history/switching-plans-history.component';
import { SwitchingPlansMultimediaComponent } from './switching-plans-new/switching-plans-multimedia/switching-plans-multimedia.component';
import { SwitchingPlansEquipmentComponent } from './switching-plans-new/switching-plans-equipment/switching-plans-equipment.component';
import { SwitchingPlansChecklistComponent } from './switching-plans-new/switching-plans-checklist/switching-plans-checklist.component';
import { MapComponent } from './map/map.component';
import { CallsComponent } from './calls/calls.component';
import { DeviceModalComponent } from './device-modal/device-modal.component';
import { TeamsComponent } from './teams/teams.component'; 

const routes: Routes = [
  {path: '', component: LoginComponent},
  {path: 'dashboard', component: DashboardComponent, canActivate: [UnregisterGuard]},
  { path: 'register', component: RegisterComponent},
  { path: 'incident-browser', component: IncidentBrowserComponent, canActivate: [UnregisterGuard]},
  {path: 'login', component: LoginComponent},
  {path: 'profile', component: ProfileComponent, canActivate: [UnregisterGuard]},
  { path: 'calls', component: CallsComponent, canActivate: [UnregisterGuard]},
  { path: 'add-device', component: AddDeviceComponent, canActivate:[UnregisterGuard]},
  { path: 'add-new-device', component: AddNewDeviceComponent, canActivate:[UnregisterGuard, WorkerGuard]},
  { path: 'add-team', component: AddTeamComponent, canActivate:[UnregisterGuard, WorkerGuard]},
  { path: 'add-consumer', component: AddConsumerComponent},
  { path: 'map', component: MapComponent},
  {path: 'notifications', component: NotificationsComponent, children: [
    {path: 'notifications-all', component: NotificationsAllComponent},
  ]},
  { path: 'incident-new', component: IncidentNewComponent, canActivate: [UnregisterGuard, WorkerGuard], children: [
    { path: 'incident-basic-info', component: IncidentBasicInfoComponent },
    { path: 'incident-devices', component: IncidentDevicesComponent },
    { path: 'incident-resolution', component: IncidentResolutionComponent },
    { path: 'incident-calls', component: IncidentCallsComponent },
    { path: 'incident-crew', component: IncidentCrewComponent },
    { path: 'incident-multimedia', component: IncidentMultimediaComponent },
    { path: 'incident-equipment', component: IncidentEquipmentComponent },
  ]},
  { path: 'work-requests', component: WorkRequestsComponent},
  { path: 'work-requests-new', component: WorkRequestsNewComponent, children: [
    { path: 'work-requests-basic-info', component: WorkRequestsBasicInfoComponent },
    { path: 'work-requests-history', component: WorkRequestsHistoryComponent },
    { path: 'work-requests-multimedia', component: WorkRequestsMultimediaComponent },
    { path: 'work-requests-equipment', component: WorkRequestsEquipmentComponent },
  ]},
  { path: 'switching-plans', component: SwitchingPlansComponent},
  { path: 'switching-plans-new', component: SwitchingPlansNewComponent, children: [
    { path: 'switching-plans-basic-info', component: SwitchingPlansBasicInfoComponent},
    { path: 'switching-plans-history', component: SwitchingPlansHistoryComponent},
    { path: 'switching-plans-multimedia', component: SwitchingPlansMultimediaComponent},
    { path: 'switching-plans-equipment', component: SwitchingPlansEquipmentComponent},
    { path: 'switching-plans-checklist', component: SwitchingPlansChecklistComponent},
  ]},
  { path: 'safety-documents', component: SafetyDocumentsComponent},
  { path: 'safety-documents-add', component: SafetyDocumentsAddComponent, children: [
    { path: 'safety-documents-basic-info', component: SafetyDocumentsBasicInfoComponent},
    { path: 'safety-documents-history', component: SafetyDocumentsHistoryComponent},
    { path: 'safety-documents-multimedia', component: SafetyDocumentsMultimediaComponent},
    { path: 'safety-documents-equipment', component: SafetyDocumentsEquipmentComponent},
    { path: 'safety-documents-checklist', component: SafetyDocumentsChecklistComponent},
  ]},
  { path: 'teams', component: TeamsComponent, canActivate:[UnregisterGuard]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
