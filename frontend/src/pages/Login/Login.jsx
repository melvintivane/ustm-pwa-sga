import React, { useState } from "react";
import "./Login.css";
import axios from "axios"

const Login = () => {
  const [credentials, setCredentials] = useState({
    NrEstudante: undefined,
    Password: undefined,
  });

  const handleChange = (e) => {
    setCredentials((previous) => ({
      ...previous,
      [e.target.id]: e.target.value,
    }));
  };

  console.log(credentials);

  const handleClick = async (e) => {
    e.preventDefault();

    try {
      const response = await axios.post("http://localhost:5115/api/login", credentials);
      console.log(response);
    } catch (error) {
      console.log(error);
    }
  }

  

  return (
    <div className="container">
      <div className="login__container">
        <div>
          <h1 className="login__title">Login</h1>
          <p className="login__text">Hi, Welcome back</p>
          <button className="button button-alt">
            <span className="icon-google"></span>Login with Google
          </button>
        </div>
        <div className="hr__container">
          <hr />
          <p className="login__text alt">or Login with Credentials</p>
          <hr />
        </div>
        <div>
          <p className="login__text">Student Id</p>
          <input
            className="login__input"
            type="text"
            placeholder="jonhdoe@email.com"
            id="NrEstudante"
            onChange={handleChange}
          />
        </div>
        <div>
          <p className="login__text">Password</p>
          <input
            className="login__input"
            type="password"
            placeholder="Enter your password"
            id="Password"
            onChange={handleChange}
          />
        </div>
        <div className="login__span">
          <p className="login__text">
            <input type="checkbox" />
            Remember me
          </p>
          <p className="login__text text-alt">Forgot password?</p>
        </div>
        <button className="button" onClick={handleClick}>Login</button>
      </div>
    </div>
  );
};

export default Login;
