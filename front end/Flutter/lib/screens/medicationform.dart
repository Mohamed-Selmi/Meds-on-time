import 'package:flutter/material.dart';
import '../services/medicationService.dart';

import '../widgets/drawerWidget.dart';

import '../models/medication.dart';
class MedicationFormScreen extends StatefulWidget {
  final Medication? medication;
  const MedicationFormScreen({super.key,this.medication});

  @override
  State<MedicationFormScreen> createState() => _MedicationFormScreenState();
}

class _MedicationFormScreenState extends State<MedicationFormScreen> {
  final _formKey=GlobalKey<FormState>();
  final TextEditingController _nameController=TextEditingController();
  final TextEditingController _descriptionController=TextEditingController();
  final TextEditingController _typeController=TextEditingController();
  final TextEditingController _sideEffectsController=TextEditingController();

  @override

  void dispose(){
    _nameController.dispose();
    _descriptionController.dispose();
    _typeController.dispose();
    _sideEffectsController.dispose();
  }
  @override
  void initState(){
    if (widget.medication!=null){
      _nameController.text=widget.medication!.name;
      _descriptionController.text=widget.medication!.description;
      _typeController.text=widget.medication!.type;
      _sideEffectsController.text=widget.medication!.sideEffects!;
    }
  }
  
  Future<void> saveMedication() async{
    if(_formKey.currentState!.validate()){
      if (widget.medication==null){
        final medication= Medication(Id:null, name: _nameController.text, description: _descriptionController.text, type: _typeController.text,sideEffects: _sideEffectsController.text);
        await MedicationService.addMedication(medication);
      }
      else{
        print(widget.medication?.Id);
        final medication= Medication(Id:widget.medication?.Id, name: _nameController.text, description: _descriptionController.text, type: _typeController.text,sideEffects: _sideEffectsController.text);
        await MedicationService.updateMedication(medication);
      }
      Navigator.pop(context);
    }
  }
  @override
  Widget build(BuildContext context) {
    final isEdit=widget.medication!=null;
    return Scaffold(
      drawer: MyDrawer(

      ),
      appBar: AppBar(title: Text(isEdit? 'Update medication' : 'Create medication'),
        backgroundColor: Colors.blue,),
        body: Padding(
            padding: const EdgeInsets.all(16),
            child: Form(
        key: _formKey,
        child: Column(
         children: [
           TextFormField(
             controller: _nameController,
             decoration: const InputDecoration(labelText: 'Medication Name:'),
             validator: (value) =>
             value == null || value.isEmpty ? 'Required field' : null,
           ),
           TextFormField(
             controller: _typeController,
             decoration: const InputDecoration(labelText: 'Medication Type:'),
             validator: (value) =>
             value == null || value.isEmpty ? 'Required field' : null,
           ),
           TextFormField(
             controller: _descriptionController,
             decoration: const InputDecoration(labelText: 'Medication Description:'),
             validator: (value) =>
             value == null || value.isEmpty ? 'Required field' : null,
           ),
           TextFormField(
             controller: _sideEffectsController,
             decoration: const InputDecoration(labelText: 'Medication side effects:'),
             validator: (value) =>
             value == null || value.isEmpty ? 'Required field' : null,
           ),
           const SizedBox(height: 20,),
           ElevatedButton(onPressed: saveMedication, child: Text(isEdit ? "Update" : "Save")),
         ],
        ),
      )
        )
    );
    return const Placeholder();
  }
}
