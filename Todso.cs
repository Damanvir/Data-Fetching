using System.Threading.Tasks;

import React, { useState, useEffect } from 'react';
import tasksData from './data/tasks.json';

const TodoForm = ({ onAddTask }) => {
    const [tasks, setTasks] = useState([]);
    const [selectedTask, setSelectedTask] = useState('');

    useEffect(() => {
        // Fetch tasks from the JSON file
        setTasks(tasksData.tasks);
    }, []);

    const handleAddTask = () => {
        const randomTask = tasks[Math.floor(Math.random() * tasks.length)];
        setSelectedTask(randomTask);
        onAddTask(randomTask);
    };

    return (
  
      < div >
  
        < input
        type = "text"
        value ={ selectedTask}
    readOnly
  />

  < button onClick ={ handleAddTask}> Generate Random Task</ button >

</ div >
  );
};

export default TodoForm;

