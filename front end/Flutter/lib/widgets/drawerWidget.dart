
import 'package:flutter/material.dart';



class MyDrawer extends StatelessWidget {
  const MyDrawer({super.key});

  @override
  Widget build(BuildContext context) {
    return Drawer(
        child: ListView(
          children: [
            DrawerHeader(
                decoration: BoxDecoration(
                    gradient: LinearGradient(colors: [
                      Colors.black26,
                      Colors.lightBlue,

                    ])
                ),
                child: Center(

                  child: CircleAvatar(
                    backgroundImage: AssetImage("assets/images/img.png"),
                    radius: 60,
                  ),
                )
            ),
            ListTile(
                title:Text("Home Page",
                  style: TextStyle(fontSize: 26,fontWeight: FontWeight.bold),),
                leading: Icon(Icons.home, color:Colors.blue),
                trailing: Icon(Icons.arrow_forward_sharp, color:Colors.black),
                onTap: (){
                  Navigator.of(context).pop();
                  Navigator.pushNamed(context,"/home");
                }
            ),
            Divider(height:5, color:Colors.black,indent: 24,endIndent: 24,),
            ListTile(
                title:Text("Medications",
                  style: TextStyle(fontSize: 26,fontWeight: FontWeight.bold),),
                leading: Icon(Icons.medication, color:Colors.red,size: 26,),
                trailing: Icon(Icons.arrow_forward_sharp, color:Colors.black),
                onTap: (){
                  Navigator.of(context).pop();
                  Navigator.pushNamed(context,"/medications");
                }
            ),
            Divider(height:5, color:Colors.black,indent: 24,endIndent: 24,),
            ListTile(
              title:Text("Users",
                style: TextStyle(fontSize: 26,fontWeight: FontWeight.bold),),
              leading: Icon(Icons.person, color:Colors.redAccent,size: 26,),
              trailing: Icon(Icons.arrow_forward_sharp, color:Colors.black),
                onTap: (){
                  Navigator.of(context).pop();
                  Navigator.pushNamed(context,"/users");
                }
            ),
            Divider(height:5, color:Colors.black,indent: 24,endIndent: 24,),
            ListTile(
                title:Text("Schedules",
                  style: TextStyle(fontSize: 26,fontWeight: FontWeight.bold),),
                leading: Icon(Icons.person, color:Colors.redAccent,size: 26,),
                trailing: Icon(Icons.arrow_forward_sharp, color:Colors.black),
                onTap: (){
                  Navigator.of(context).pop();
                  Navigator.pushNamed(context,"/users");
                }
            )
          ],
        )
    );
  }
}

