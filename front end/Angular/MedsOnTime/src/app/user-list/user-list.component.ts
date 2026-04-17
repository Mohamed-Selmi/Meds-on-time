import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';
import { User } from '../shared/models/user';

@Component({
  selector: 'app-user-list',
  standalone: true,
  imports: [CommonModule,HttpClientModule],
  templateUrl: './user-list.component.html',
  styleUrl: './user-list.component.css',
  providers:[UserService]
})
export class UserListComponent implements OnInit{
  usersData : any; 
  
  
  constructor(private userService: UserService){}
  async getAllUsers(){
   await this.userService.getAllUsers().subscribe(
      res=>{
        this.usersData=res;
      }
    )
  }
  async deleteUser(user: User){
    await this.userService.deleteUser(user).subscribe();
    await this.getAllUsers();
  }
  async addUser(user: User){
    
  }
  ngOnInit(): void {
    this.getAllUsers();
  }
}
