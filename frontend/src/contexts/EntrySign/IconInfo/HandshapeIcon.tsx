import React, { useEffect, useState } from 'react';
import './IconInfo.css';

interface HandshapeIconProps {
  handshape: string;
}

const HandshapeIcon = ({ handshape }: HandshapeIconProps) => {
  // State to hold the resolved image path
  const [handshapeImagePath, setHandshapeImagePath] = useState<string | null>(
    null
  );

  useEffect(() => {
    const loadImage = async () => {
      try {
        // Dynamically import the image
        const imageModule = await import(
          `../../../assets/handshape-icons/${handshape}-haand.png`
        );
        setHandshapeImagePath(imageModule.default);
      } catch (error) {
        // If the image doesn't exist, you can set it to a default image or null
        console.error('Image not found', error);
        setHandshapeImagePath(null);
      }
    };

    if (handshape) {
      loadImage();
    }
  }, [handshape]);

  return (
    <div className="facts">
      {handshapeImagePath ? (
        <img
          src={handshapeImagePath}
          alt={`${handshape} handshape`}
          className="handshape-image"
        />
      ) : (
        <div className="handshape-placeholder">{handshape}</div>
      )}
    </div>
  );
};

export default HandshapeIcon;
