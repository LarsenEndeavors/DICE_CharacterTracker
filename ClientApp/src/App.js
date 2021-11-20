import React from 'react';

import './custom.css';
import './styles/style.css';
import Home from "./components/Home";
import {Layout} from "./components/Layout";
import {Route} from "react-router-dom";
import {ApplicationPaths} from "./components/api-authorization/ApiAuthorizationConstants";
import ApiAuthorizationRoutes from "./components/api-authorization/ApiAuthorizationRoutes";

const App = () => {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
      </Layout>
    );
};

export default App;