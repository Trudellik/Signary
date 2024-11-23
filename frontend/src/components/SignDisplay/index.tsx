import React from 'react';
import './SignDisplay.css';

import EntrySignVideo from '../../contexts/EntrySign/EntrySignVideo';
import EntryDescription from '../../contexts/EntrySign/EntryDescription';

const SignDisplay = () => {
  return (
    <div className="entry">
      <EntrySignVideo />
      <EntryDescription />
    </div>
  );
};

export default SignDisplay;
