import React from 'react'
import { Button, Card, CardContent, TextField, Typography } from '@mui/material'
import { Box } from '@mui/system'

import Center from './Center'
import useForm from '../hooks/useForm'
import { ENDPOINTS, createAPIEndpoint } from '../api'

const getFreshModel = () => ({
    email: '',
    name: ''
})

export default function Login() {

    const{
        values,
        // setValues,
        errors,
        setErrors,
        handleInputChange
    } = useForm(getFreshModel);

    const login = e => {
        e.preventDefault();
        if (validate()){
            createAPIEndpoint(ENDPOINTS.Participant).post(values).then(res => console.log(res)).catch(error => console.log(error));
        }
    }

    const validate = () => {
       let temp = {}
       temp.email = (/\S+@\S+\.\S+/).test(values.email) ? "" : "Email is not valid."
       temp.name = values.name !== "" ? "" : "This field is required."
       setErrors(temp)
       return Object.values(temp).every(x => x === "")
    }

    return (
        <Center>
            <Card sx={{ 
                width: 400, 
                }}>
                <CardContent sx={{textAlign:"center"}}>
                    <Typography variant="h3" sx={{my:3}}>
                        Dev Quiz
                    </Typography>
                    <Box sx={{
                            width: 500,
                            maxWidth: '100%',
                    }}>
                        <form noValidate autoComplete="off" onSubmit={login}>
                        <TextField 
                            fullWidth 
                            label="Email"
                            name="email"
                            variant="outlined"
                            margin="dense"
                            value={values.email}
                            onChange={handleInputChange}
                            {...(errors.email && { error: true, helperText: errors.email })} 
                        />
                            <TextField 
                                fullWidth 
                                label="Name"
                                name="name"
                                variant="outlined"
                                margin="dense"
                                value={values.name}
                                onChange={handleInputChange}
                                {...(errors.name && { error: true, helperText: errors.name })} 
                            />
                            <Button
                                type="submit"
                                variant="contained"
                                size="large"
                                sx={{ width: '100%' }}>Log in</Button>
                        </form>
                    </Box>
                </CardContent>
            </Card>
        </Center>
    )
}