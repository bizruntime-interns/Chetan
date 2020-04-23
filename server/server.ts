import express from 'express';
import{Application} from "express";

 
const app:Application=express();

app.route('/api/courses').get((req,res)=>{
    res.status(200).json({"message":"Hello World"})
});


app.listen(8090,()=>{
    console.log("server is running on port 8090");
});
