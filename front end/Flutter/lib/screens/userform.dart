import 'package:flutter/material.dart';
import '../services/medicationService.dart';

import '../widgets/drawerWidget.dart';

import '../models/user.dart';

class UserFormScreen extends StatefulWidget {
  final User? user;
  const UserFormScreen({super.key,this.user});

  @override
  State<UserFormScreen> createState() => _UserFormScreenState();
}

class _UserFormScreenState extends State<UserFormScreen> {
  final _formKey=GlobalKey<FormState>();
  final TextEditingController _firstnameController=TextEditingController();
  final TextEditingController _lastNameController=TextEditingController();
  final TextEditingController _emailController=TextEditingController();
  final TextEditingController _dateOfBirthController=TextEditingController();
  final TextEditingController _genderController=TextEditingController();

  @override

  void dispose(){
    _firstnameController.dispose();
    _lastNameController.dispose();
    _emailController.dispose();
    _dateOfBirthController.dispose();
    _genderController.dispose();
  }
@override
void initState(){
  if (widget.user!=null){
    _firstnameController.text=widget.user!.firstName;
    _lastNameController.text=widget.user!.lastName;
    _emailController.text=widget.user!.email;
    _dateOfBirthController.text=widget.user!.dateOfBirth;
    _genderController.text=widget.user!.gender!;
  }
}
  @override
  Widget build(BuildContext context) {
    return const Placeholder();
  }
}
