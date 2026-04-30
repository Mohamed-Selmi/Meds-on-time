
import 'package:flutter/material.dart';
import 'package:medsontime/services/userService.dart';
import '../widgets/drawerWidget.dart';

import '../models/user.dart';

class UsersPage extends StatefulWidget {
  const UsersPage({super.key});

  @override
  State<UsersPage> createState() => _UsersPageState();
}

class _UsersPageState extends State<UsersPage> {
  List<User> users=[];
  @override
  void initState(){
    super.initState();
    print("test");

    loadUsers();

  }
  Future<void> loadUsers() async{
    final data=await UserService.getUsers();
    print("wahahaha!");
    print(data);
    setState(() {
      users=data;

    });
  }
  Future<void> deleteUser(User u) async{
    try{
      await UserService.deleteUser(u);
      loadUsers();
    }
    catch (e){
      debugPrint(e.toString());
    }
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: MyDrawer(

      ),
      appBar: AppBar(title: Text('Users',
      ),
        actions: <Widget>[
          IconButton(onPressed: ()=>{
            Navigator.of(context).pop(),
            Navigator.pushNamed(context,"/medicationsForm")
          }, icon: const Icon(Icons.add))
        ]
        ,
        backgroundColor: Colors.red,),
      body: users.isEmpty ? const Center(child: Text('No Users found'),)
          :
      ListView.builder(
          itemCount: users.length,
          itemBuilder: (context,index){
            final u=users[index];
            return ListTile(

              title: Text('FirstName: ${u.firstName} \n LastName: ${u.lastName}'),
              subtitle: Text(u.dateOfBirth as String),
              trailing: Row(
                mainAxisSize: MainAxisSize.min,

                children: [
                  IconButton(onPressed: ()=> null /*{
                    Navigator.of(context).pop(),
                    Navigator.push(context, MaterialPageRoute(builder: (context)=>MedicationFormScreen(medication: u,)))
                  }*/, icon: const Icon(Icons.update)),
                  IconButton(onPressed: ()=>deleteUser(u), icon: const Icon(Icons.delete)),
                  IconButton(onPressed: ()=>null, icon: const Icon(Icons.arrow_forward_sharp)),

                ],

              ),
            );

          }

      ),

    );
  }
}

