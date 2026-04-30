
import 'package:flutter/material.dart';
import '../widgets/drawerWidget.dart';

class Homepage extends StatelessWidget {
  const Homepage({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        drawer: MyDrawer(

        ),
        appBar: AppBar(title: Text("HomePage"),
          backgroundColor: Colors.lightBlue,),
        body: Center(
          child:Text("Home Page",
            style:Theme.of(context).textTheme.headlineSmall,),
        )
    );
  }
}
