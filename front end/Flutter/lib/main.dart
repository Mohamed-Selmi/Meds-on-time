import 'package:flutter/material.dart';
import 'package:medsontime/screens/homepage.dart';
import 'package:medsontime/screens/medicationform.dart';
import 'package:medsontime/screens/medications.dart';
import 'package:medsontime/screens/users.dart';

void main() {
  runApp(const MyApp());
}
class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      routes: {
        "/home":(context){
          return Homepage();
        },
        "/medications":(context){
          return MedicationPage();
        },
        "/medicationsForm":(context){
          return MedicationFormScreen();
        },
        "/users":(context){
          return UsersPage();
        }

      },
      debugShowCheckedModeBanner: false,
      theme: ThemeData(primarySwatch: Colors.lightBlue),
      initialRoute: "/home",
    );
  }
}
